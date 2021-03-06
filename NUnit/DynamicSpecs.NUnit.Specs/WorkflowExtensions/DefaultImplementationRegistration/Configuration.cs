﻿namespace DynamicSpecs.NUnit.Specs.WorkflowExtensions.DefaultImplementationRegistration
{
    using DynamicSpecs.Core.WorkflowExtensions;

    using global::NUnit.Framework;
    
    [SetUpFixture]
    public class Configuration : Extensions
    {
        [OneTimeSetUp]
        public void RegisterExtensions()
        {
            Provide<DefaultImplemenation, IDefaultImplementation>();
        }
    }
}