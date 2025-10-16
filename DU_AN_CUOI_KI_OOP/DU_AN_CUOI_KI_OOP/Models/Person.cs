using System;

public abstract class Person
{
    private int _id;
    private string _name;

    public int Id
    {
        get => _id;
        set
        {
            if (value <= 0)
                throw new ArgumentException("ID phải lớn hơn 0");
            _id = value;
        }
    }

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Tên không được để trống");
            _name = value;
        }
    }

    public virtual string GetInfo()
    {
        return $"ID: {Id}, Họ tên: {Name}";
    }
}
