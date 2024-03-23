using PhotoBase.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Xml.Serialization;

namespace PhotoBase.Model
{
    internal static class UsersBase
    {

        /// <summary>
        /// Имя для файла.
        /// </summary>
        private const string settingsFileName = "UsersBase.xml";
        /// <summary>
        /// Таймер автосохранений.
        /// </summary>
        public static DispatcherTimer TimerAutosave = new DispatcherTimer { Interval = new TimeSpan(0, 0, 5) };

        /// <summary>
        /// Сохраняемые значения.
        /// </summary>
        public static ObservableCollection<UsersClass> Values;

        private static Exception LastException;
        /// <summary>
        /// Последнее сообщение об ошибке
        /// </summary>
        public static Exception GetException()
        { return LastException; }


        /// <summary>
        /// Инициализация.
        /// </summary>
        /// <returns></returns>
        public static bool Initialize()
        {
            if (TimerAutosave != null)
                TimerAutosave.Tick += TimerAutosave_Tick;

            if (File.Exists(settingsFileName))
            {
                Read();
                return true;
            }
            else
            {
                SetDefault();
                Save();
                return false;
            }
        }

        /// <summary>
        /// Прекращение автоматических сохранений. Возобновить можно переинициализировав.
        /// </summary>
        public static void AutoSaveStop()
        {
            TimerAutosave.Stop();
            Save();
        }

        private static void TimerAutosave_Tick(object sender, EventArgs e)
        {
            Save();
        }

        /// <summary>
        /// Установить базовые значения.
        /// </summary>
        public static void SetDefault() => Values = null;

        /// <summary>
        /// Сохранить настройки.
        /// </summary>
        /// <returns></returns>
        public static bool Save()
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(ObservableCollection<UsersClass>));
                using (FileStream fs = new FileStream(settingsFileName, FileMode.Create))
                    ser.Serialize(fs, Values);

                return true;
            }
            catch (Exception ex)
            {
                LastException = ex;
                return false;
            }
        }

        /// <summary>
        /// Считать записанные настройки.
        /// </summary>
        /// <returns></returns>
        public static bool Read()
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(ObservableCollection<UsersClass>));
                using (FileStream fs = new FileStream(settingsFileName, FileMode.Open))
                    Values = (ObservableCollection<UsersClass>)ser.Deserialize(fs);

                return true;
            }
            catch (Exception ex)
            {
                SetDefault();
                LastException = ex;
                return false;
            }
        }
    }

}
