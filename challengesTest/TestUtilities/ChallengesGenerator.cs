using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using challenges.Models;

namespace challengesTest.TestUtilities
{
    public static class ChallengesGenerator
    {
        public static List<UserChallenge> CreateList(int quantity, bool group_id)
        {
            List<UserChallenge> list = new List<UserChallenge>();
            for (var i = 0; i < quantity; i++)
            {
                list.Add(group_id ? CreateUserChallengeGroup(i) : CreateUserChallengePersonal(i));
            }

            return list;
        }

        public static UserChallenge CreateInvalidChallenge()
        {
            return new UserChallenge
            {
                UserChallengeId = 1,
                UserId = "TestUid",
                Challenge = new Challenge
                {
                    ChallengeId = 2,
                    StartDateTime = new DateTime().Add(TimeSpan.FromDays(1)),
                    EndDateTime = new DateTime().Add(TimeSpan.FromDays(2)),
                    Goal = 1000,
                    GoalMetric = "TestGoalMetric",
                    Repeat = false,
                    Activity = new Activity
                    {
                        ActivityId = 3,
                        ActivityName = "TestActivityName"
                    },
                    ActivityId = 3,
                    IsGroupChallenge = true,
                    Groupid = "7"
                },
                PercentageComplete = 0,
                ChallengeId = 2
            };
        }

        public static UserChallenge CreateUserChallengePersonal(int id)
        {
            var aId = 10 + id;
            var cId = 20 + id;
            var uId = 30 + id;
            return new UserChallenge
            {
                UserChallengeId = uId,
                UserId = "TestUid",
                Challenge = new Challenge
                {
                    ChallengeId = cId,
                    StartDateTime = new DateTime().Add(TimeSpan.FromDays(1)),
                    EndDateTime = new DateTime().Add(TimeSpan.FromDays(2)),
                    Goal = 1000 + cId,
                    GoalMetric = "TestGoalMetric",
                    Repeat = false,
                    Activity = new Activity
                    {
                        ActivityId = aId,
                        ActivityName = "TestActivityName" + aId
                    },
                    ActivityId = aId,
                    IsGroupChallenge = false
                },
                PercentageComplete = 0,
                ChallengeId = cId
            };
        }

        public static UserChallenge CreateUserChallengeGroup(int id)
        {
            var aId = 10 + id;
            var cId = 20 + id;
            var uId = 30 + id;
            var gId = "55";
            return new UserChallenge
            {
                UserChallengeId = uId,
                UserId = "TestUid",
                Challenge = new Challenge
                {
                    ChallengeId = cId,
                    StartDateTime = new DateTime().Add(TimeSpan.FromDays(1)),
                    EndDateTime = new DateTime().Add(TimeSpan.FromDays(2)),
                    Goal = 1000 + cId,
                    GoalMetric = "TestGoalMetric",
                    Repeat = false,
                    Activity = new Activity
                    {
                        ActivityId = aId,
                        ActivityName = "TestActivityName" + aId
                    },
                    ActivityId = aId,
                    IsGroupChallenge = true,
                    Groupid = gId
                },
                PercentageComplete = 0,
                ChallengeId = cId
            };
        }
    }
}