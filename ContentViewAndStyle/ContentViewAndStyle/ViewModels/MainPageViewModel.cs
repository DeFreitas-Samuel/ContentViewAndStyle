using ContentViewAndStyle.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewAndStyle.ViewModels
{
    class MainPageViewModel 
    {
        public MenuOption Option1 { get; }
        public MenuOption Option2 { get; }
        public MenuOption Option3 { get; }
        public MenuOption Option4 { get; }
        public MenuOption Option5 { get; }
        public MenuOption Option6 { get; }

        public MainPageViewModel()
        {
            Option1 = new MenuOption("credit_cards_icon", "Credit Cards", "3 availables");
            Option2 = new MenuOption("digital_transfer_icon", "Digital Transfer", "Personal Funds: $325.08");
            Option3 = new MenuOption("currency_exchange_icon", "Currency Exchange", "Not available at the moment");
            Option4 = new MenuOption("savings_icon", "Savings", "Saving Account: $10,249.07");
            Option5 = new MenuOption("vault_icon", "Vault", "Not available at the moment");
            Option6 = new MenuOption("bank_icon", "Go to bank", "Connection Available");
        }

    }
}
