using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Chat322_Client
{
    public class FSWork // Класс для работы с файловой системой
    {
        
        static public List<string> ReadIniFile(List<string> _param, string _path)
        {
            List<string> result = new List<string>();
            string _file = ReadAllFile(_path);
            string[] _values = _file.Split('\n');
            int _start, _count;
            foreach (string item in _values)
            {
                for (int i = 0; i < _param.Count; i++)
                {
                    if (item.Contains(_param[i])) 
                    {
                        _start = item.IndexOf('\"') + 1;
                        _count = item.LastIndexOf('\"') - _start;
                        result.Add(item.Substring
                            (_start, _count));
                    }
                }
            }
            return result;
        }
        static public string ReadAllFile(string _path)
        {
            string result = string.Empty;
            using (StreamReader sr = new StreamReader(_path))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }
        static public bool IsDBExists(string path) // Проверка существования БД с  пользователями
        {
            if (File.Exists(path)) return true;
            return false;
        }
        
    }
}
