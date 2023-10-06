using MvvmWizard.Classes;
using System.Threading.Tasks;
using WizardDemo.Classes;

namespace WizardDemo.ViewModels.Simple {
    public class RegistrationViewModel : StepViewModelBase {
        private bool isProcessing;

        private string firstName;

        private string lastName;

        private string email;

        //実行処理中か否かを示す値を取得または設定します。
        //「処理中はUIを一部無効にする」などの処理を実装するために使用します。
        //例)インストール処理中は「キャンセル」ボタンを無効にする
        public bool IsProcessing {
            get { return this.isProcessing; }
            set { this.SetProperty(ref this.isProcessing, value); }
        }

        //ユーザが入力するFirstNameを取得または設定します。
        public string FirstName {
            get { return this.firstName; }
            set {
                this.SetProperty(ref this.firstName, value);
                RaisePropertyChanged(nameof(MyIsEnabled));
            }
        }

        //ユーザが入力するLastNameを取得または設定します。
        public string LastName {
            get { return this.lastName; }
            set {
                this.SetProperty(ref this.lastName, value);
                RaisePropertyChanged(nameof(MyIsEnabled));
            }
        }

        //ユーザが入力するEmailを取得または設定します。
        public string Email {
            get { return this.email; }
            set {
                this.SetProperty(ref this.email, value);
                RaisePropertyChanged(nameof(MyIsEnabled));
            }
        }

        //入力フィールドに有効なデータが入力されているか否かを示す値を取得します。
        //今回ですと、FirstName, LastName, Emailのがすべて埋まっていたらtrueを返します。
        //public bool MyIsEnabled => !string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(lastName) &&
        //                           !string.IsNullOrWhiteSpace(Email);

        ///デバッグのために強制的にTrueにしています。
        public bool MyIsEnabled = true;

        /// <summary>
        /// ステップ間の遷移時に実行される処理を実装します。
        /// ステップを進むごとに呼ばれるメソッドです。
        /// </summary>
        /// <param name="transitionContext">次ステップに渡すコンテキスト</param>
        /// <returns></returns>
        public override async Task OnTransitedFrom(TransitionContext transitionContext) {

            //遷移先ステップが遷移元ステップよりも前のステップの場合は何もしない
            //後戻りの場合あは何も処理しないようにするため
            if (transitionContext.TransitToStep < transitionContext.TransitedFromStep) {
                return;
            }

            //遷移先ステップに渡すコンテキストにユーザが入力した情報を設定する
            //以下だと、
            transitionContext.SharedContext[nameof(UserDetails)] = new UserDetails(this.FirstName, this.LastName, this.Email);

            try {
                this.IsProcessing = true;
                await Task.Delay(3000);
            }
            finally {
                this.IsProcessing = false;
            }
        }
    }

}
