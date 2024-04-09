using System;
using System.Collections.Generic;

public class CBMember
{
    // Attributes
    private string _cjbName { get; set; }
    private int _cjbId { get; set; }
    private string _cjbEmail { get; set; }
    private List<CBMember> _cjbMemberList { get; set; } // Field
    public List<CBMember> CjbMemberList //Property
    {
        get { return _cjbMemberList; }
        set { _cjbMemberList = value; }
    }

    // Constructors
    public CBMember(string name, int id, string email)
    {
        _cjbName = name;
        _cjbId = id;
        _cjbEmail = email;
    }
    public CBMember()
    {
        _cjbMemberList = new List<CBMember>();
    }

    // Methods
    public string GetEmail()
    {
        return _cjbEmail;
    }

    public void CBAddMember()
    {
        Console.WriteLine("\nPlease answer a couple questions to become a member: ");
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();

        Console.WriteLine("Create an ID no: (must be 8 digits of only numbers.)");
        int id;
        while (!int.TryParse(Console.ReadLine(), out id) || id.ToString().Length != 8)
        {
            Console.WriteLine("Please enter a valid 8-digit ID number: ");
        }

        Console.WriteLine("Please enter your email: ");
        string email = Console.ReadLine();

        // Create a new CBMember object
        CBMember newMember = new CBMember(name, id, email);

        // Add the new member to the list
        _cjbMemberList.Add(newMember);

        Console.WriteLine("Member added successfully!\n");
    }

    public void CBDisplayMembers(List<CBMember> MemberListPar)
    {
        foreach (CBMember member in MemberListPar)
        {
            Console.WriteLine($"Member name: {member._cjbName}");
        }
    }
}
