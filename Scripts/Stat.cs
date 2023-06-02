namespace DefaultNamespace;

public class Stat
{
    #region Fields

    public int baseValue;
    public List<StatMod> modList;
    
    #endregion

    #region Constructors

    

    #endregion

    #region Properties



    #endregion

    #region Methods

    void AddMod(StatMod mod)
    {
        modList.Add(mod);
    }
    
    bool RemoveMod(StatMod mod)
    {
        return modList.Remove(mod);
    }

    void SortMods()
    {
        modList.Sort( (a,b) => a.modType.CompareTo(b.modType) );
    }

    #endregion
}