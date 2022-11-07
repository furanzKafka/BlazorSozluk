﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorSozluk.Common.Infrastructure.Results
{
    public class ValidationResponseModel
    {
        public IEnumerable<string> Errors { get; set; }

        public ValidationResponseModel(IEnumerable<string> errors)
        {
            Errors = errors;
        }

        public ValidationResponseModel(string message) : this(new List<string>() { message })
        {

        }

        [JsonIgnore]        //if i use anything only in my system, can not return this property i can use [JsonIgnore]
        public string FlattenErrors => Errors != null
            ? string.Join(Environment.NewLine, Errors)
            : string.Empty;
    }
}
