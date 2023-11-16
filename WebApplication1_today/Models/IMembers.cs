namespace WebApplication1_today.Models
{
    public interface IMembers
    {
        List<Members> GetAllMembers();
        Members GetMember(int id);
        Members Add(Members member);
        Members Update(int id, Members membersChanges);
        Members Delete(int id);
        List<Members> GetAllMemberbyname(string name);
        List<Members> GetAllMemberbyaddress(string address);

    }
}
