using AutoMapper;
using Overt.GrpcTemplate.Application.Models;
using Overt.GrpcTemplate.Domain.Entities;
using System;

namespace Overt.GrpcTemplate.Application
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            #region Output
            CreateMap<AccountEntity, AccountModel>();
            #endregion

            #region Input
            #endregion

            #region 公共
            CreateMap<long, DateTime>().ConvertUsing(new LongToDateTimeConverter());
            CreateMap<DateTime, long>().ConvertUsing(new DateTimeToLongConverter());
            CreateMap<string, string>().ConvertUsing(new StringNullToEmpty());
            CreateMap<DateTime, string>().ConvertUsing(new DateTimeToStringConverter());
            #endregion
        }
    }

    public class DateTimeToLongConverter : ITypeConverter<DateTime, long>
    {
        public long Convert(DateTime source, long destination, ResolutionContext context)
        {
            return source.Ticks;
        }
    }

    public class LongToDateTimeConverter : ITypeConverter<long, DateTime>
    {
        public DateTime Convert(long source, DateTime destination, ResolutionContext context)
        {
            if (source == 0)
            {
                return default(DateTime);
            }
            else
            {
                return new DateTime(source);
            }
        }
    }

    public class StringNullToEmpty : ITypeConverter<string, string>
    {
        public string Convert(string source, string destination, ResolutionContext context)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                return string.Empty;
            }

            return source;
        }
    }

    public class DateTimeToStringConverter : ITypeConverter<DateTime, string>
    {
        public string Convert(DateTime source, string destination, ResolutionContext context)
        {
            if (source == default(DateTime))
            {
                return "";
            }
            else
            {
                return source.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
    }
}
