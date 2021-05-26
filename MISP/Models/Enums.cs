using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace MISP
{
    //public enum FoodCategories
    //{
    //    Hotdog,
    //    Drink,
    //    Shawarma,
    //    Other
    //}

    public enum OrderStatuses
    {
        Created,
        Accepted,
        Preparing,
        Submited,
        Completed,
        Canceled
    }
}