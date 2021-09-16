
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using data.entities;
using data.repo;


namespace teamAkshay_Aquarium_p1.Models
{
    public class Mapper
    {
        public static teamAkshay_Aquarium_p1.Models.User Map(data.entities.User user)
        {
            return new teamAkshay_Aquarium_p1.Models.User()
            {
                id = user.id,
                name = user.name,
                roleId = user.roleId,
                genderId=user.genderId,
                email = user.email,
                phone_Number=user.phone_Number,
                username=user.username,
                password=user.password

            };
        }
    }
}