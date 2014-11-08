using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Windows.Forms;

namespace HttpTestTool
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            layout.BestFit();
        }

        /// <summary>
        /// send http request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click(object sender, EventArgs e)
        {
            var method = (Method)radioGroup_method.Properties.Items[radioGroup_method.SelectedIndex].Value;
            var request = new RestRequest(method);
            var client = new RestClient(txtEdit_url.EditValue + "");
            var data = txtEdit_data.EditValue + "";

            // 
            if (method == Method.GET)
            {
                IDictionary<String, String> dic = new Dictionary<String, String>();
                getQSParametersFromJObject(JsonConvert.DeserializeObject<JContainer>(data), ref dic);
                if (0 < dic.Count)
                {
                    foreach (var item in dic)
                    {
                        request.AddQueryParameter(item.Key, item.Value);
                    }
                }
            }
            else
            {
                request.AddJsonBody(JsonConvert.DeserializeObject<ExpandoObject>(data));
            }

            // 
            var response = client.Execute(request);
            treeList_response.BeginUnboundLoad();
            try
            {
                treeList_response.ClearNodes();
                AppendNodes(JsonConvert.DeserializeObject<JContainer>(response.Content), null, null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex + "", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            treeList_response.EndUnboundLoad();
            treeList_response.ExpandAll();
        }

        private void getQSParametersFromJObject(JToken token, ref IDictionary<String, String> dic)
        {
            foreach (var item in token)
            {
                if (item is JValue)
                {
                    var path = item.Path;
                    if (item.Parent is JArray)
                    {
                        path = String.Format("{0}.[]", path.Substring(0, path.LastIndexOf("[")));
                    }

                    // 
                    var arr = path.Split('.');
                    var key = arr[0];
                    var length = arr.Length;
                    if (1 < length)
                    {
                        for (var i = 1; i < length; i++)
                        {
                            var index = arr[i].IndexOf("[");
                            if (-1 == index)
                            {
                                key += String.Format("[{0}]", arr[i]);
                            }
                            else if (0 == index)
                            {
                                key += arr[i];
                            }
                            else
                            {
                                key += "[" + arr[i].Insert(index, "]");
                            }
                        }
                    }

                    // 
                    dic.Add(key, (item as JValue).Value + "");
                }
                else
                {
                    getQSParametersFromJObject(item, ref dic);
                }
            }
        }

        private void AppendNodes(JToken token, string name, TreeListNode parent)
        {
            if (token is JValue)
            {
                var value = token as JValue;
                treeList_response.AppendNode(new Object[] { string.Format("{0}: {1}", name, value.Value) }, parent);
                return;
            }

            if (token is JObject || token is JArray)
            {
                var node = !String.IsNullOrWhiteSpace(name) ?
                    treeList_response.AppendNode(new Object[] { name }, parent) :
                    null;
                if (token is JObject)
                {
                    var obj = token as JObject;
                    foreach (var property in obj.Properties())
                    {
                        AppendNodes(property.Value, property.Name, node);
                    }

                }
                else
                {
                    var array = token as JArray;
                    var count = array.Count;
                    for (var i = 0; i < count; i++)
                    {
                        AppendNodes(array[i], string.Format("[{0}]", i), node);
                    }
                }
            }
        }
    }
}
