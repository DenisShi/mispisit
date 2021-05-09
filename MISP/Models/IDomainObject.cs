using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace MISP
{
    public interface IDomainObject
    {
        int Id { get; set; }
    }
}