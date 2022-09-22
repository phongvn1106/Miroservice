using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Core.Models.Response
{
    public class Message
    {
        public Message(string key, string valueVietNam, string valueUs)
        {
            Key = key;
            ValueVietNam = valueVietNam;
            ValueUs = valueUs;
        }
        public Message()
        {

        }
        public string Key { get; set; }
        public string ValueVietNam { get; set; }
        public string ValueUs { get; set; }

        public static List<Message> GetMessages()
        {
            List<Message> messages = new List<Message>
            {
                new Message("","Thông tin đăng nhập không hợp lệ",""),
                new Message("","Mật khẩu không hợp lệ",""),
                new Message("","Không có quyền truy cập",""),
                new Message("","",""),
                new Message("","",""),
                new Message("","",""),
                new Message("","",""),
            };
            return messages;
        }
    }
}
