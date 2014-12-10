using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraTreeList.Nodes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HttpTestTool
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();

            // init validation rules
            // txtEdit_url
            UrlValidationRule urlValidationRule = new UrlValidationRule();
            urlValidationRule.ErrorText = "Please enter a valid url";
            urlValidationRule.ErrorType = ErrorType.Default;
            dxValidationProvider.SetValidationRule(txtEdit_url, urlValidationRule);

            // txtEdit_data
            DataValidationRule dataValidationRule = new DataValidationRule();
            dataValidationRule.ErrorText = "Please enter a valid json string";
            dataValidationRule.ErrorType = ErrorType.Default;
            dxValidationProvider.SetValidationRule(txtEdit_data, dataValidationRule);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            layout.BestFit();
        }

        #region CustomValidationRule
        public class UrlValidationRule : ValidationRule
        {
            public override bool Validate(Control control, object value)
            {
                string str = value + "";
                return !String.IsNullOrWhiteSpace(str) && Uri.IsWellFormedUriString(str, UriKind.Absolute);
            }
        }

        public class DataValidationRule : ValidationRule
        {
            public override bool Validate(Control control, object value)
            {
                string str = value + "";
                bool res = true;
                if (!String.IsNullOrWhiteSpace(str))
                {
                    try
                    {
                        JObject.Parse(str);
                    }
                    catch (Exception)
                    {
                        res = false;
                    }
                }
                return res;
            }
        }
        #endregion

        /// <summary>
        /// send http request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click(object sender, EventArgs e)
        {
            // validate
            if (!dxValidationProvider.Validate()) return;

            // 
            var method = (Method)radioGroup_method.Properties.Items[radioGroup_method.SelectedIndex].Value;
            var request = new RestRequest(method);
            var data = txtEdit_data.EditValue + "";

            // 
            if (!String.IsNullOrWhiteSpace(data))
            {
                if (method == Method.GET)
                {
                    IDictionary<String, String> dic = new Dictionary<String, String>();
                    getQSParametersFromJObject(JsonConvert.DeserializeObject<JContainer>(data), ref dic);
                    if (0 < dic.Count)
                    {
                        Array.ForEach(dic.ToArray(), (item) => request.AddQueryParameter(item.Key, item.Value));
                    }
                }
                else
                {
                    request.AddJsonBody(JsonConvert.DeserializeObject<ExpandoObject>(data));
                }
            }

            // execute
            var client = new RestClient(txtEdit_url.EditValue + "");
            var response = client.Execute(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                XtraMessageBox.Show(response.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 
            treeList_response.BeginUnboundLoad();
            try
            {
                treeList_response.ClearNodes();
                AppendNodes(JsonConvert.DeserializeObject<JContainer>(response.Content), null, null);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    dic.Add(getPath(item), (item as JValue).Value + "");
                }
                else
                {
                    getQSParametersFromJObject(item, ref dic);
                }
            }
        }

        private string getPath(JToken token)
        {
            if (token.Parent == null)
            {
                return string.Empty;
            }

            IList<JToken> ancestors = token.Ancestors().Reverse().ToList();
            ancestors.Add(token);

            var count = ancestors.Count;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                JToken current = ancestors[i];
                JToken next = null;
                if (i + 1 < ancestors.Count)
                {
                    next = ancestors[i + 1];
                }
                else if (ancestors[i].Type == JTokenType.Property)
                {
                    next = ancestors[i];
                }

                if (next != null)
                {
                    switch (current.Type)
                    {
                        case JTokenType.Property:
                            var property = current as JProperty;
                            if (sb.Length <= 0)
                            {
                                sb.Append(property.Name);
                            }
                            else
                            {
                                sb.Append("[").Append(property.Name).Append("]");
                            }
                            break;
                        case JTokenType.Array:
                        case JTokenType.Constructor:
                            sb.Append("[").Append((current as IList<JToken>).IndexOf(next)).Append("]");
                            break;
                    }
                }
            }

            // 
            return sb.ToString();
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