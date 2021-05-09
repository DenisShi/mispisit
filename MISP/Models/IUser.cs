using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace MISP
{
    public interface IUser : IDomainObject
    {
        string Phone { get; set; }
        string Name { get; set; }
        string Address { get; set; }
    }
}