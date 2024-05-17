using System;

namespace PlayerManager4
{
    private readonly bool ascending;

    public CompareByName(bool ascending)
    {
        this.ascending = ascending;
    }
    public int Compare(Player x, Player y)
    {
        if (ascending)
        {
            return string.Compare(x.Name, y.Name);
        }
        else
        {
            return false;
        }
    }
}