﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CUSTOMERREGISTRATIONAPI.Model
{
    public class Customer
    {


        /// <summary>
        /// Customer Id
        /// </summary>
        public int CustomerId { get; set; }


        [NotMapped]
        public string EncryptedCustomerId { get; set; }
        /// <summary>
        /// Customer 15 digits Code
        /// </summary>
        public string CustomerCode { get; set; }

        /// <summary>
        /// Customer Full Name
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Customer MobileNumber
        /// </summary>
        public string CustomerPhone { get; set; } = null;
        /// <summary>
        /// Customer Email
        /// </summary>
        public string CustomerEmail { get; set; } = null;
        /// <summary>
        /// Customer Password
        /// </summary>
        public string CustomerPassword { get; set; } = null;
        /// <summary>
        /// Customer State Id
        /// </summary>
        public int? StateId { get; set; }
        [NotMapped]
        public string encStateId { get; set; } = null;
        /// <summary>
        /// Customer District Id
        /// </summary>
        public int? DistrictId { get; set; }
        [NotMapped]
        public string encDistrictId { get; set; } = null;
        /// <summary>
        /// Customer City
        /// </summary>
        public string City { get; set; } = null;
        /// <summary>
        /// Customer Address Pincode
        /// </summary>
        public int? Pincode { get; set; }
        /// <summary>
        /// Customer Gender
        /// </summary>
        public string CustomerGender { get; set; } = null;
        /// <summary>
        /// Customer Address
        /// </summary>
        public string CustomerAddress { get; set; } = null;
        public string StateName { get; set; } = null;
        public string DistrictName { get; set; } = null;
    }
    public class State
    {
        /// <summary>
        /// State Id
        /// </summary>
        public int? StateId { get; set; }
        /// <summary>
        /// State Name
        /// </summary>
        public string StateName { get; set; } = null;
    }

    public class District
    {
        /// <summary>
        /// District Id
        /// </summary>
        public int? DistrictId { get; set; }
        /// <summary>
        /// Selected State Id
        /// </summary>
        public int? StateId { get; set; }
        /// <summary>
        /// District Name 
        /// </summary>
        public string DistrictName { get; set; } = null;
    }
    public class Errorlogs
    {
        public string ErrorMessage { get; set; }
        public DateTime ErrorDate { get; set; }
        public string ErrorOn { get; set; }
        public string ErrorLineNo { get; set; }
        public string ErrorStackTrace { get; set; }
    }

    ////--------------------Encrypt & Decrypt-----------------------------
    //public class CustomDataProtection
    //{
    //    public readonly string customerIdValue = "customerIdValue";

    //}
}
