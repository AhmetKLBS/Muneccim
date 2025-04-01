using Python.Runtime;
using System;

namespace DeepShakeUI
{
    public static class DeepShakeModel
    {
        // Python yolu (örneğin: C:/Python39/python.exe)
        private static string PythonPath = @"C:\Python39\python.exe";

        static DeepShakeModel()
        {
            // Python ortamını başlat
            PythonEngine.PythonHome = PythonPath;
            PythonEngine.PythonPath = PythonPath;
            PythonEngine.Initialize();
        }

        public static dynamic Predict(string filePath)
        {
            try
            {
                using (Py.GIL()) // Global Interpreter Lock
                {
                    // DeepShake GitHub deposundaki Python dosyasını yükle
                    dynamic deepshake = Py.Import("DeepShake.predict");

                    // Modeli çalıştır ve sonucu al
                    dynamic result = deepshake.run_model(filePath);
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
                return null;
            }
            finally
            {
                PythonEngine.Shutdown();
            }
        }
    }
}