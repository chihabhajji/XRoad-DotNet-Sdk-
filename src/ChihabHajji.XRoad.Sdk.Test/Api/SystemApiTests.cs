/*
 * X-Road Security Server Admin API
 *
 * X-Road Security Server Admin API. Note that the error metadata responses described in some endpoints are subjects to change and may be updated in upcoming versions.
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: info@niis.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using ChihabHajji.XRoad.Sdk.Client;
using ChihabHajji.XRoad.Sdk.Api;
// uncomment below to import models
//using ChihabHajji.XRoad.Sdk.Model;

namespace ChihabHajji.XRoad.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing SystemApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SystemApiTests : IDisposable
    {
        private SystemApi instance;

        public SystemApiTests()
        {
            instance = new SystemApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SystemApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SystemApi
            //Assert.IsType<SystemApi>(instance);
        }

        /// <summary>
        /// Test AddConfiguredTimestampingService
        /// </summary>
        [Fact]
        public void AddConfiguredTimestampingServiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TimestampingService timestampingService = null;
            //var response = instance.AddConfiguredTimestampingService(timestampingService);
            //Assert.IsType<TimestampingService>(response);
        }

        /// <summary>
        /// Test DeleteConfiguredTimestampingService
        /// </summary>
        [Fact]
        public void DeleteConfiguredTimestampingServiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TimestampingService timestampingService = null;
            //instance.DeleteConfiguredTimestampingService(timestampingService);
        }

        /// <summary>
        /// Test DownloadAnchor
        /// </summary>
        [Fact]
        public void DownloadAnchorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DownloadAnchor();
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test DownloadSystemCertificate
        /// </summary>
        [Fact]
        public void DownloadSystemCertificateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DownloadSystemCertificate();
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GenerateSystemCertificateRequest
        /// </summary>
        [Fact]
        public void GenerateSystemCertificateRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DistinguishedName distinguishedName = null;
            //var response = instance.GenerateSystemCertificateRequest(distinguishedName);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GenerateSystemTlsKeyAndCertificate
        /// </summary>
        [Fact]
        public void GenerateSystemTlsKeyAndCertificateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GenerateSystemTlsKeyAndCertificate();
        }

        /// <summary>
        /// Test GetAnchor
        /// </summary>
        [Fact]
        public void GetAnchorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAnchor();
            //Assert.IsType<Anchor>(response);
        }

        /// <summary>
        /// Test GetConfiguredTimestampingServices
        /// </summary>
        [Fact]
        public void GetConfiguredTimestampingServicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetConfiguredTimestampingServices();
            //Assert.IsType<List<TimestampingService>>(response);
        }

        /// <summary>
        /// Test GetNodeType
        /// </summary>
        [Fact]
        public void GetNodeTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetNodeType();
            //Assert.IsType<NodeTypeResponse>(response);
        }

        /// <summary>
        /// Test GetSystemCertificate
        /// </summary>
        [Fact]
        public void GetSystemCertificateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSystemCertificate();
            //Assert.IsType<CertificateDetails>(response);
        }

        /// <summary>
        /// Test ImportSystemCertificate
        /// </summary>
        [Fact]
        public void ImportSystemCertificateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream body = null;
            //var response = instance.ImportSystemCertificate(body);
            //Assert.IsType<CertificateDetails>(response);
        }

        /// <summary>
        /// Test PreviewAnchor
        /// </summary>
        [Fact]
        public void PreviewAnchorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? validateInstance = null;
            //System.IO.Stream body = null;
            //var response = instance.PreviewAnchor(validateInstance, body);
            //Assert.IsType<Anchor>(response);
        }

        /// <summary>
        /// Test ReplaceAnchor
        /// </summary>
        [Fact]
        public void ReplaceAnchorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream body = null;
            //instance.ReplaceAnchor(body);
        }

        /// <summary>
        /// Test SystemVersion
        /// </summary>
        [Fact]
        public void SystemVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SystemVersion();
            //Assert.IsType<VersionInfo>(response);
        }

        /// <summary>
        /// Test UploadInitialAnchor
        /// </summary>
        [Fact]
        public void UploadInitialAnchorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream body = null;
            //instance.UploadInitialAnchor(body);
        }
    }
}