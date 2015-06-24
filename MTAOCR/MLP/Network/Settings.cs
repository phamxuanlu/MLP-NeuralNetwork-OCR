using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MLP.Network
{

    public static class StringExtension
    {
        public static bool Contains(this List<string> src, Predicate<string> x)
        {
            for (int i = 0; i < src.Count; i++)
            {
                if (x(src[i]))
                {
                    return true;
                }
            }
            return false;
        }

    }
    [Serializable]
    public class Settings
    {
        private Dictionary<string, object> ConfigData;

        public object this[string key]
        {
            get
            {
                if (!ConfigData.ContainsKey(key))
                    return null;
                return ConfigData[key];
            }
            set
            {
                if (!ConfigData.ContainsKey(key))
                {
                    ConfigData.Add(key, value);
                }
                else
                {
                    ConfigData[key] = value;
                }
            }
        }

        public List<string> getAllKeys()
        {
            return ConfigData.Keys.ToList();

        }
        public bool Remove(string key)
        {

            return ConfigData.Remove(key);
        }

        public Settings()
        {

            ConfigData = new Dictionary<string, object>();

            //Nếu không tồn tại file Config.ini hoặc bị xóa thì đọc file Config.ini mặc định trong Network.dll
            //Và ghi vào file Config.ini
            //Để nhúng được file vào DLL thì phải đặt file đó là Embedded Resource
            if (!File.Exists("Config.ini"))
            {
                FileStream fstr = File.Create("Config.ini");
                Stream stream = Assembly.GetAssembly(typeof(Settings)).GetManifestResourceStream("MLP.Network.Config.Config.ini");
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyTo(fstr);
                fstr.Flush();
                fstr.Close();
            }

            try
            {
                StreamReader config = new StreamReader("Config.ini", Encoding.ASCII);
                List<string> lstStr = config.ReadToEnd().Split('\n').ToList();

                config.Close();

                lstStr.RemoveAll(x => x.StartsWith(";"));
                lstStr.RemoveAll(x => string.IsNullOrEmpty(x.Trim()));
                for (int i = 0; i < lstStr.Count; i++)
                {
                    lstStr[i] = lstStr[i].Trim('\r');
                }
                foreach (string s in lstStr)
                {
                    string[] arr = s.Split('=');

                    switch (arr[0])
                    {

                        case "NumberOfLayers":
                            ConfigData.Add("NumberOfLayers", int.Parse(arr[1]));
                            break;
                        case "LearningRate":
                            ConfigData.Add("LearningRate", double.Parse(arr[1]));
                            break;
                        case "EpochToStop":
                            ConfigData.Add("EpochToStop", int.Parse(arr[1]));
                            break;
                        case "EpochPreventOverfitting":
                            ConfigData.Add("EpochPreventOverfitting", int.Parse(arr[1]));
                            break;
                        case "ErrorToStop":
                            ConfigData.Add("ErrorToStop", double.Parse(arr[1]));
                            break;
                        case "TransferFunction":
                            ConfigData.Add("TransferFunction", arr[1]);
                            break;
                        case "Momentum":
                            ConfigData.Add("Momentum", double.Parse(arr[1]));
                            break;
                        case "ErrorThresholdPercent":
                            ConfigData.Add("ErrorThresholdPercent", int.Parse(arr[1]));
                            break;
                        case "LearningRateDownStep":
                            ConfigData.Add("LearningRateDownStep", double.Parse(arr[1]));
                            break;
                        case "LearningRateUpStep":
                            ConfigData.Add("LearningRateUpStep", double.Parse(arr[1]));
                            break;
                    }
                }
                int layers = (int)ConfigData["NumberOfLayers"];
                for (int i = 1; i <= layers; i++)
                {
                    string s = lstStr.Find(x => x.Contains("NeuronsOfLayer[" + i + "]"));
                    if (!string.IsNullOrEmpty(s))
                    {
                        string[] arr = s.Split('=');
                        ConfigData.Add("NeuronsOfLayer[" + i + "]", int.Parse(arr[1]));
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception("Invalid configuration file");
            }

        }
        /// <summary>
        /// Lấy tất cả các class trong namespace MLP.Network.TransferFunctions tức là các hàm truyền
        /// </summary>
        /// <returns></returns>
        public static List<string> getAllTranferFunctions()
        {
            string @namespace = "MLP.Network.TransferFunctions";
            List<string> kq = new List<string>();
            var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace == @namespace
                    select t;
            q.ToList().ForEach(t => kq.Add(t.Name));
            return kq;
        }

        public void Save()
        {
            String temp = "";

            Settings oldsetting = new Settings();
            StreamReader config = new StreamReader("Config.ini", Encoding.ASCII);
            temp = config.ReadToEnd();
            config.Close();
            // Xóa tất cả về số nơ ron của lớp để nạp lại
            temp = temp.Remove(temp.IndexOf("NeuronsOfLayer["));

            temp = temp.Replace("NumberOfLayers=" + oldsetting["NumberOfLayers"], "NumberOfLayers=" + ConfigData["NumberOfLayers"]);
            temp = temp.Replace("LearningRate=" + oldsetting["LearningRate"], "LearningRate=" + ConfigData["LearningRate"]);
            temp = temp.Replace("Momentum=" + oldsetting["Momentum"], "Momentum=" + ConfigData["Momentum"]);
            temp = temp.Replace("EpochToStop=" + oldsetting["EpochToStop"], "EpochToStop=" + ConfigData["EpochToStop"]);
            temp = temp.Replace("ErrorToStop=" + oldsetting["ErrorToStop"], "ErrorToStop=" + ConfigData["ErrorToStop"]);
            temp = temp.Replace("ErrorThresholdPercent=" + oldsetting["ErrorThresholdPercent"], "ErrorThresholdPercent=" + ConfigData["ErrorThresholdPercent"]);
            temp = temp.Replace("LearningRateUpStep=" + oldsetting["LearningRateUpStep"], "LearningRateUpStep=" + ConfigData["LearningRateUpStep"]);
            temp = temp.Replace("LearningRateDownStep=" + oldsetting["LearningRateDownStep"], "LearningRateDownStep=" + ConfigData["LearningRateDownStep"]);
            temp = temp.Replace("TransferFunction=" + oldsetting["TransferFunction"], "TransferFunction=" + ConfigData["TransferFunction"]);

            // nạp lại nơ ron của lớp
            foreach (string key in ConfigData.Keys)
            {
                if (key.Contains("NeuronsOfLayer["))
                    temp += key + "=" + ConfigData[key] + Environment.NewLine;

            }

            StreamWriter writer = new StreamWriter("Config.ini", false, Encoding.ASCII);
            writer.Write(temp);
            writer.Close();
        }
    }
}
