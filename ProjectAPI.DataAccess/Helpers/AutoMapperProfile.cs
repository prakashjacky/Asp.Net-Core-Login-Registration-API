using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ProjectAPI.DataAccess.Entities;
using ProjectAPI.DataAccess.Entities.Models;

namespace ProjectAPI.DataAccess.Helpers
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<User, UserModel>();
			CreateMap<RegisterModel, User>();
			CreateMap<UpdateModel, User>();
		}
	}
}
