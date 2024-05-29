﻿using System.ComponentModel.DataAnnotations;
using Fina.Core.Enums;

namespace Fina.Core.Requests.Transactions;

public class GetTransactionByIdRequest : Request
{
    public long Id { get; set; }
}