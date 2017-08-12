namespace _05.Security_Door
{
    public class PinCodeCheck : SecurityCheck
    {
        private IPinCodeUI securityUI;

        public PinCodeCheck(IPinCodeUI securityUI)
        {
            this.securityUI = securityUI;
        }

        private bool IsValid(int pin)
        {
            return true;
        }

        public override bool ValidateUser()
        {
            int pin = securityUI.RequestPinCode();
            if (IsValid(pin))
            {
                return true;
            }

            return false;
        }
    }
}