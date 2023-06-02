namespace DefaultNamespace;

public struct StatMod
{
    #region Fields

    public readonly int value;
    public readonly StatModType modType;
    public readonly object source;
    

    #endregion

    #region Constructors

    public StatMod(int val, StatModType type, source)
    {
        value = val;
        modType = type;
        this.source = source;
    }

    #endregion
    
}

public enum StatModType
{
    flat,
    additive,
    multiplicative,
    other
}