using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using Domain;

namespace BLL.Factories
{
    public class CvFactory
    {
        public CvSmallDTO createCvSmallDTO(Cv cv)
        {
            return new CvSmallDTO
            {
                CvId = cv.CvId,
                Title = cv.Title
            };
        }

        public CvFullDTO createCvFullDTO(Cv cv)
        {
            return new CvFullDTO
            {
                CvId = cv.CvId,
                Title = cv.Title,
                CvCreatedOn = cv.CvCreatedOn,
                CvUpdatedOn = cv.CvUpdatedOn,
                Location = cv.Location,
                UserId = cv.UserId,
                User = cv.User
            };
        }
    }
}
