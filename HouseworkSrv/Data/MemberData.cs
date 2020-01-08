using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net.Http;


namespace HouseworkManager.Data
{



    public class Member
    {
        public string Nickname { get; set; } = "";
        public int PointsPerWeek { get; set; } = 100;
    }


    public class MemberService
    {

        [Inject]
        public HttpClient Http { get; set; }

        //  [Inject]
        //  public AppData appdata { get; set; }

        public List<Member> members = new List<Member>();

        public List<Member> AddDefaultsAsync()
        {
            //  await Http.GetJsonAsync<Member[]>("sample-data/member.json");
            if (members.Count == 0)
            {
                Member x = new Member()
                {
                    Nickname = "Martin",
                    PointsPerWeek = 66
                };

                members.Add(x);

                members.Add(new Member()
                {
                    Nickname = "Nuria",
                    PointsPerWeek = 76
                });
            }
            return members;
        }

        public List<Member> Add(String CurrentNickname, int CurrentPointsperweek)
        {
            members.Add(new Member()
            {
                Nickname = CurrentNickname,
                PointsPerWeek = CurrentPointsperweek
            });
            return members;
        }


    }



}


