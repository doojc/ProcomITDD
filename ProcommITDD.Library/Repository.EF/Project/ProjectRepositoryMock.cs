using ProcommITDD.Library.Model.Entities;
using ProcommITDD.Library.Repository.EF.Interfaces;
using ProcommITDD.Library.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProcommITDD.Library.Services.ViewModels;

namespace Procomm.DdPlatform.Repository
{
    public class ProjectRepositoryMock : IProjectRepository
    {
        public IEnumerable<ProjectSummaryView> GetAll(int userId)
        {
            return null;
        }

        public ProjectStatusDTO GetProjectStatistics(int? id)
        {
            List<TopicStatusDTO> topics = new List<TopicStatusDTO>
                {
                    new TopicStatusDTO { TopicId = 1, TopicName = "TestTopicOne", Progress = "30%" },
                    new TopicStatusDTO { TopicId = 2, TopicName = "TestTopicTwo", Progress = "60%" },
                    new TopicStatusDTO { TopicId = 3, TopicName = "TestTopicThree", Progress = "40%" },
                    new TopicStatusDTO { TopicId = 4, TopicName = "TestTopicFour", Progress = "50%" },
                    new TopicStatusDTO { TopicId = 5, TopicName = "TestTopicFive", Progress = "100%" }
                };

            List<InformantStatusDTO> informants = new List<InformantStatusDTO>
                {
                    new InformantStatusDTO { InformantId = 1, InformantName = "TestInformantOne", NumberOfQuestions = 100, NumberOfAnswers = 60, Progress = "60%" },
                    new InformantStatusDTO { InformantId = 1, InformantName = "TestInformantOne", NumberOfQuestions = 100, NumberOfAnswers = 60, Progress = "60%" }
                };

            ProjectStatusDTO projectStatus = new ProjectStatusDTO()
            {
                ProjectId = 1,
                Topics = topics,
                Informants = informants,
                NumberOfQuestions = 100,
                NumberOfAnswers = 85,
                Progress = "85%"
            };

            return projectStatus;
        }

        public List<ProjectQuestion> GetProjectQuestions(int projectId)
        {
            return null;
        }
    }
}