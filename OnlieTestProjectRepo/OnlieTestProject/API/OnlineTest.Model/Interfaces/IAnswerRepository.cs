﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTest.Models.Interfaces
{
    public interface IAnswerRepository
    {
        IEnumerable<Answer> GetAnswers();
        IEnumerable<Answer> GetAnswersByQuestionId(int questionId);
        int AddAnswer(Answer answer);
        int UpdateAnswer(Answer answer);
        bool DeleteAnswer(Answer answer);
        Answer GetAnswersById(int id);
    }
}
