using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat322_Client
{
    partial class TCPClient
    {        
        
        public static IPAddress _ipAddress;// ip сервера
        public static int _outPort = 3000;// _outPort - порт сервера
        public static int _inPort;// _inPort - порт клиента
        public static string ip = "127.0.0.1";

        public static string _activeGroup = "234";
        public static int _idclient = 0;
        public static string _PersonName = "";

        public static TcpClient myclient = null;
        public static NetworkStream stream {  get; private set; }
        public Thread sendThread {  get; private set; }
        public Thread receiveThread {  get; private set; }
        public TCPClient() { }





        //УСТАНОВКА ip АДРЕСА И ПОРТОВ ИЗ ФАЙЛА ПРИ ЗАПУСКЕ
        public void SetConfig()
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] fileInfo = directoryInfo.GetFiles();
            List<string> srtfile = new List<string>();
            foreach (FileInfo finfo in fileInfo)
            {
                if(finfo.Name == "Cfg.ini")
                {
                    srtfile.AddRange(File.ReadAllLines(finfo.FullName));
                }
            }
            _ipAddress = IPAddress.Parse(srtfile[0]);
            _outPort = int.Parse(srtfile[1]);
            _inPort = int.Parse(srtfile[2]);

        }


        public void StartClient()
        {
            try
            {
                SetConfig();
                myclient = new TcpClient(ip, _outPort);//TcpClient client = new TcpClient(ip, _outPort);
                stream = myclient.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }


        /// <summary>
        /// ОТПРАВКА СООБЩЕНИЯ
        /// </summary>
        /// <param name="ms"></param>
        public void mysendmes(string ms)
        {
            Task task = new Task(() => {
                byte[] data = Encoding.UTF8.GetBytes($"{ms}&{_activeGroup}&{_idclient}&{_PersonName}");
                stream.Write(data, 0, data.Length);
            });
            task.Start();
        }

        /// <summary>
        /// получение данных
        /// </summary>
        /// <param name="stream"></param>
        public string MyReceiveMessages()
        {
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string response= "Ничего не пришло";
            bool check = true;
            try
            {
                while (check)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    response=Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    if (response != null) check = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return response;
        }

        /// <summary>
        /// СОХРАНЕНИЕ СООБЩЕНИЯ В JSON ФАЙЛ
        /// </summary>
        /// <returns></returns>
        public string MyReceiveMessagesJson() 
        {
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string response = "Ничего не пришло";
            bool check = true;
            try
            {
                while (check)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    //var ff = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    //response = reader.ReadLine();
                    //if (response == null)break;
                    if (response != null) check = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Console.WriteLine($"Ошибка при получении данных: {ex.Message}");
            }
            return response;
        }




        //ИЗВЛЕЧЕНИЕ ID УЧАСТНИКА ИЗ ВХОДЯЩЕГО СООБЩЕНИЯ
        public static int getClIdFromMes(string str)
        {
            int i = Int32.Parse(str);
            return i;
        }

        /// <summary>
        /// ДЕЛЕНИЕ ВХОДЯЩЕЙ СТРОКИ НА МАССИВ СТРОК
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string[] getCldataFromMes(string str)
        {
            string[] splitstr = str.Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
            return splitstr;
        }


        public static string AuthorizationClient(string str)
        {
           /*//bool check = false;
            //using (NetworkStream stream = myclient.GetStream())
            //{
            //    //Console.WriteLine("Подключено к серверу .");
            //    while (check)
            //    {
            //        //Console.Write("Введите сообщение: ");
            //        //string message = Console.ReadLine();
            //        //if (message.ToLower() == "exit") break;

            //        byte[] data = Encoding.UTF8.GetBytes($"{str}");
            //        stream.Write(data, 0, data.Length);

            //        byte[] buffer = new byte[1024];
            //        int bytesRead = stream.Read(buffer, 0, buffer.Length);
            //        string dr = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            //        if (dr != null) check = true;
            //        //Console.WriteLine("Ответ сервера: " + Encoding.UTF8.GetString(buffer, 0, bytesRead));
            //    }
            //}
            //while (check==false)
            //{
                //Console.Write("Введите сообщение: ");
                //string message = Console.ReadLine();
                //if (message.ToLower() == "exit") break;

            */

                byte[] data = Encoding.UTF8.GetBytes($"{str}");
                stream.Write(data, 0, data.Length);

                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string dr = Encoding.UTF8.GetString(buffer, 0, bytesRead);

               /* //if (dr == "avt-Проверьте верность введённых данных или зарегистрируйтесь!")
                //{
                //    MessageBox.Show(dr, "Ошибка", MessageBoxButtons.OK);
                //}
                //else
                //{
                //    check=true;
                //}
                //Console.WriteLine("Ответ сервера: " + Encoding.UTF8.GetString(buffer, 0, bytesRead));
            //}
            */
            return dr;
        }

        public static bool RegistrationClient(string str)
        {
            bool checkReg = false;
            byte[] data = Encoding.UTF8.GetBytes($"{str}");
            stream.Write(data, 0, data.Length);

            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string dr = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            if(dr=="okk")
            {
                checkReg = true;
            }
            return checkReg;
        }



    }
}

// Запуск потоков для отправки и приёма сообщений
//Thread sendThread = new Thread(() => MySendMessage(stream));
//Thread receiveThread = new Thread(() => MyReceiveMessages(stream));

//sendThread = new Thread(() => MySendMessage(stream));
//receiveThread = new Thread(() => MyReceiveMessages(stream));

//sendThread.Start();
//receiveThread.Start();

//sendThread.Join();
//receiveThread.Join();

// Закрытие соединения
//stream.Close();
//myclient.Close();

//================================================================================
///// <summary>
///// ОТПРАВКА СООБЩЕНИЯ ДЛЯ АВТОРИЗАЦИИ
///// </summary>
///// <param name="ms"></param>
//public void sendmesavtorization(string ms)
//{
//    Task task = new Task(() => {
//        byte[] data = Encoding.UTF8.GetBytes($"{ms}");
//        stream.Write(data, 0, data.Length);
//    });
//    task.Start();
//}




