 public class CBLoan
 {
 // Attributes
    private CBMember _cjbMember;
    private CBLibraryItem _cjbItem;
    private DateTime _cjbLoanDate;
    private DateTime _cjbDueDate;

    // Constructors
    public CBLoan(CBMember member, CBLibraryItem item, DateTime loanDate, DateTime dueDate) {
        _cjbMember = member;
        _cjbItem = item;
        _cjbLoanDate = loanDate;
        _cjbDueDate = dueDate;
    }

    // Methods
    // Change this to float: not void.
    public void CalculateFine() 
    {
        // Implementation for calculating fine
    }

    public void DisplayLoanDetails() {
        // Implementation for displaying loan details
    }
}