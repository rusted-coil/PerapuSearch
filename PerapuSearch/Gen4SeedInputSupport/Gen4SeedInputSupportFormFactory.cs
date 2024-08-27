using PerapuSearch.Gen4SeedInputSupport.Internal;
using System.Runtime.Versioning;

namespace PerapuSearch.Gen4SeedInputSupport
{
    internal class Gen4SeedInputSupportFormFactory
    {
        static Gen4SeedInputSupportFormPresenter? s_Form = null;

        // 設定はアプリ起動中のみ保持する
        static Gen4SeedInputSupportFormConfig s_Config = new Gen4SeedInputSupportFormConfig();

        /// <summary>
        /// 第4世代入力補助フォームを開きます。
        /// <para> * 既に開かれている場合はフォーカスし、nullを返します。</para>
        /// </summary>
        /// <returns>第4世代入力補助フォームで決定が押された時の初期seed候補の文字列を通知するストリーム</returns>
        [SupportedOSPlatform("windows")]
        public static IObservable<string>? OpenOrFocusForm()
        {
            if (s_Form == null)
            {
                s_Form = new Gen4SeedInputSupportFormPresenter(s_Config);
                s_Form.FormClosing.Subscribe(_ => s_Form = null);
                s_Form.Show();
                return s_Form.InputTextDecided;
            }
            else
            {
                s_Form.Focus();
                return null;
            }
        }
    }
}
