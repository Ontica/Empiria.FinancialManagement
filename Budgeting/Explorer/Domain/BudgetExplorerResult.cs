﻿/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Budget Explorer                            Component : Domain Layer                            *
*  Assembly : Empiria.Budgeting.Explorer.dll             Pattern   : Information Holder                      *
*  Type     : BudgetExplorerResult                       License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Holds the dynamic result of a budget explorer execution.                                       *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/

using Empiria.DynamicData;

using Empiria.Budgeting.Explorer.Adapters;

namespace Empiria.Budgeting.Explorer {

  /// <summary>Holds the dynamic result of a budget explorer execution.</summary>
  internal class BudgetExplorerResult {

    public BudgetExplorerQuery Query {
      get; internal set;
    }

    public FixedList<DataTableColumn> Columns {
      get; internal set;
    }

    public FixedList<BudgetDataInColumns> Entries {
      get; internal set;
    }

  }  // class BudgetExplorerResult

}  // namespace Empiria.Budgeting.Explorer
