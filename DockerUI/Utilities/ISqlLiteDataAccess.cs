using System.Collections.Generic;

namespace DockerUI.Utilities
{
    public interface ISqlLiteDataAccess
    {
        List<T> LoadData<T>(string sql);
        void SaveData<T>(T person, string sql);
        void UpdateData<T>(T person, string sql);
    }
}