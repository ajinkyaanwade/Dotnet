namespace WebApplication1_today.Models
{
    public class MemberRepository : IMembers
    {
        public static List<Members> lismembers = new List<Members>
        {
            new Members{MemberId = 1, FirstName="Ajinkya",LastName="Anwade",Address="Kannad"},
            new Members{MemberId = 2, FirstName="Abhay",LastName="Anwade",Address="Kannad"},
            new Members{MemberId = 3, FirstName="Sushil",LastName="Gavit",Address="Kannad"},
            new Members{MemberId = 4, FirstName="Sachin",LastName="Ahire",Address="Kannad"},
        };
        public Members Add(Members member)
        {
            member.MemberId = lismembers.Max(e => e.MemberId) + 1;
            lismembers.Add(member);
            return member;

        }

        public Members Delete(int id)
        {
            Members members = lismembers.FirstOrDefault(e => e.MemberId == id);
            if (members != null)
            {
                lismembers.Remove(members);
            }
            return members;

        }

        public List<Members> GetAllMemberbyname(string name)
        {
            return lismembers.FindAll((nm) => nm.FirstName == name);

        }

        public List<Members> GetAllMemberbyaddress(string address)
        {
            return lismembers.FindAll((nm) => nm.Address == address);

        }


        public List<Members> GetAllMembers()
        {
            return lismembers;
        }

        public Members GetMember(int id)
        {
            return lismembers.FirstOrDefault(x => x.MemberId == id);
        }

        public Members Update(int id, Members membersChanges)
        {
            if (id == membersChanges.MemberId)
            {
                Members member = lismembers.FirstOrDefault(e => e.MemberId == membersChanges.MemberId);
                if (member != null)
                {
                    member.FirstName = membersChanges.FirstName;
                    member.LastName = membersChanges.LastName;
                    member.Address = membersChanges.Address;
                }
                return member;
            }
            return null;
        }
    }
}
