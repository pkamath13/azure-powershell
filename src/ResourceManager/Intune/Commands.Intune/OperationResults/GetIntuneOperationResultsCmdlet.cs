﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Intune
{
    using Management.Intune;
    using Management.Intune.Models;
    using Microsoft.Azure.Commands.Intune.Properties;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Management.Automation;

    /// <summary>
    /// Cmdlet to get existing Operation results.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "AzureRmIntuneOperationResults", SupportsShouldProcess = true), OutputType(typeof(PSObject))]
    public sealed class GetIntuneOperationResultsCmdlet : IntuneBaseCmdlet
    {
        /// <summary>
        /// Contains the cmdlet's execution logic.
        /// </summary>
        protected override void ProcessRecord()
        {
            GetOperationResults();
        }

        /// <summary>
        /// Get all OperationResults
        /// </summary>
        private void GetOperationResults()
        {
            MultiPageGetter<OperationResult> mpg = new MultiPageGetter<OperationResult>();

            List<OperationResult> items = mpg.GetAllResources(
                this.IntuneClientWrapper.GetOperationResults,
                this.IntuneClientWrapper.GetOperationResultsNext,
                this.AsuHostName,
                filter: null,
                top: null,
                select: null);

            this.WriteObject(items, enumerateCollection: true);
        }
    }
}
