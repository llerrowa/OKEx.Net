using CryptoExchange.Net.Converters;
using Okex.Net.Enums;
using System.Collections.Generic;

namespace Okex.Net.Converters
{
    internal class DepositStateConverter : BaseConverter<OkexDepositState>
    {
        public DepositStateConverter() : this(true) { }
        public DepositStateConverter(bool quotes) : base(quotes) { }

        protected override List<KeyValuePair<OkexDepositState, string>> Mapping => new List<KeyValuePair<OkexDepositState, string>>
        {
            new KeyValuePair<OkexDepositState, string>(OkexDepositState.WaitingForConfirmation, "0"),
            new KeyValuePair<OkexDepositState, string>(OkexDepositState.Credited, "1"),
            new KeyValuePair<OkexDepositState, string>(OkexDepositState.Successful, "2"),
            new KeyValuePair<OkexDepositState, string>(OkexDepositState.Pending, "8"),
        };
    }
}