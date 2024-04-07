namespace TechnicalTiagnosis.Core.Entities;
public class TechnicalForm
{
    public TechnicalForm()
    {
        Confirm = false;
    }

    public int Id { get; set; }
    public User User { get; set; }
    public Car Car { get; set; }
    public DateOnly CreateAt { get; set; }
    public bool Confirm { get; private set; }

    public void SetConfirm()
    {
        Confirm = true;
    }
}


