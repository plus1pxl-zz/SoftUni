﻿using System.Collections.Generic;
using Phonebook.Data.Models;

namespace Phonebook.Data
{
    public class DataAccess
    {
        public static List<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
