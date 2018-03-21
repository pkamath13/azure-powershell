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

extern alias NewSDK;

using NewSDK::Microsoft.Azure.Management.Monitor.Models;

namespace Microsoft.Azure.Commands.Insights.OutputClasses
{
    /// <summary>
    /// Wrapps around the RuleGetResponse
    /// </summary>
    public class PSAlertRule : AlertRuleResource
    {
        /// <summary>
        /// Initializes a new instance of the PSAlertRule class.
        /// </summary>
        /// <param name="ruleSpec"></param>
        public PSAlertRule(AlertRuleResource ruleSpec)
            : base(
                  location: ruleSpec.Location,
                  alertRuleResourceName: ruleSpec.AlertRuleResourceName,
                  isEnabled: ruleSpec.IsEnabled,
                  condition: ruleSpec.Condition,
                  id: ruleSpec.Id,
                  name: ruleSpec.Name,
                  type: ruleSpec.Type,
                  tags: ruleSpec.Tags,
                  description: ruleSpec.Description,
                  actions: ruleSpec.Actions,
                  lastUpdatedTime: ruleSpec.LastUpdatedTime)
        {
        }
    }
}
