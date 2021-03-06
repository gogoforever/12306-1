﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paway.Ticket.Package.Data;
using Newtonsoft.Json;

namespace Paway.Ticket.Package
{
    [Serializable]
    public class ResponseCheckLogin : ResponseBase
    {
        public CheckLoginData Data
        {
            get
            {
                CheckLoginData data = null;
                if (base.data != null && base.data.ToString() != string.Empty)
                {
                    data = JsonConvert.DeserializeObject<CheckLoginData>(base.data.ToString());
                }
                return data;
            }
        }
    }
}
