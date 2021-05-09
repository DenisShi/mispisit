using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace MISP
{
    public interface IProduct : IDomainObject
    {
        float Price { get; set; }
        string Name { get; set; }
    }
}