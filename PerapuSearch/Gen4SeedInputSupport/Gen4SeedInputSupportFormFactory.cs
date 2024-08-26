using PerapuSearch.Gen4SeedInputSupport.Internal;

namespace PerapuSearch.Gen4SeedInputSupport
{
    internal class Gen4SeedInputSupportFormFactory
    {
        static Gen4SeedInputSupportFormPresenter? s_Form = null;

        /// <summary>
        /// 第4世代入力補助フォームを開きます。
        /// <para> * 既に開かれている場合はフォーカスし、nullを返します。</para>
        /// </summary>
        /// <returns>第4世代入力補助フォームで決定が押された時の初期seed候補の文字列を通知するストリーム</returns>
        public static IObservable<string>? OpenOrFocusForm()
        {
            if (s_Form == null)
            {
                s_Form = new Gen4SeedInputSupportFormPresenter();
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
