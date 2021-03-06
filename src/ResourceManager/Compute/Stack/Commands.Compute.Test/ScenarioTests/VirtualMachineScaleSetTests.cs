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

using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;

namespace Microsoft.Azure.Commands.Compute.Test.ScenarioTests
{
    public partial class VirtualMachineScaleSetTests
    {
        public VirtualMachineScaleSetTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            ServiceManagemenet.Common.Models.XunitTracingInterceptor.AddToContext(new ServiceManagemenet.Common.Models.XunitTracingInterceptor(output));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestVirtualMachineScaleSet()
        {
            ComputeTestController.NewInstance.RunPsTest("Test-VirtualMachineScaleSet");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestVirtualMachineScaleSet_ManagedDisks()
        {
            ComputeTestController.NewInstance.RunPsTest("Test-VirtualMachineScaleSet-ManagedDisks");
        }
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestVirtualMachineScaleSetReimageUpdate()
        {
            ComputeTestController.NewInstance.RunPsTest("Test-VirtualMachineScaleSetReimageUpdate");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestVirtualMachineScaleSetLB()
        {
            ComputeTestController.NewInstance.RunPsTest("Test-VirtualMachineScaleSetLB");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestVirtualMachineScaleSetNextLink()
        {
            ComputeTestController.NewInstance.RunPsTest("Test-VirtualMachineScaleSetNextLink");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestVirtualMachineScaleSetBootDiagnostics()
        {
            ComputeTestController.NewInstance.RunPsTest("Test-VirtualMachineScaleSetBootDiagnostics");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestVirtualMachineScaleSetIdentity()
        {
            ComputeTestController.NewInstance.RunPsTest("Test-VirtualMachineScaleSetIdentity");
        }
    }
}
