using LinkBoxWeb.Constants;
using LinkBoxWeb.DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace LinkBoxWeb.Extensions
{
    public static class HttpContextExtensions
    {
        public static User GetLinkBoxUser(this HttpContext httpContext, LinkBoxContext context)
        {
            if (httpContext.Request.Cookies.ContainsKey(MagicStrings.SessionGuidKey))
            {
                var sessionGuidString = httpContext.Request.Cookies[MagicStrings.SessionGuidKey];
                Guid sessionGuid = Guid.Empty;
                if (Guid.TryParse(sessionGuidString, out sessionGuid))
                {
                    var session = context.Sessions.Include(s => s.User).FirstOrDefault(_session => _session.SessionGuid == sessionGuid);
                    if (session != null)
                    {
                        return session.User;
                    }
                }
            }

            return null;
        }
    }
}