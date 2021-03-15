// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.MachineLearningServices.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The EnvironmentSpecificationVersions service client. </summary>
    public partial class EnvironmentSpecificationVersionsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal EnvironmentSpecificationVersionsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of EnvironmentSpecificationVersionsOperations for mocking. </summary>
        protected EnvironmentSpecificationVersionsOperations()
        {
        }

        /// <summary> Initializes a new instance of EnvironmentSpecificationVersionsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Azure subscription identifier. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal EnvironmentSpecificationVersionsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-09-01-preview")
        {
            RestClient = new EnvironmentSpecificationVersionsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <param name="name"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> The EnvironmentSpecificationVersionResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EnvironmentSpecificationVersionResource>> CreateOrUpdateAsync(string name, string version, string resourceGroupName, string workspaceName, EnvironmentSpecificationVersionResource body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnvironmentSpecificationVersionsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(name, version, resourceGroupName, workspaceName, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="name"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> The EnvironmentSpecificationVersionResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EnvironmentSpecificationVersionResource> CreateOrUpdate(string name, string version, string resourceGroupName, string workspaceName, EnvironmentSpecificationVersionResource body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnvironmentSpecificationVersionsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(name, version, resourceGroupName, workspaceName, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get version. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EnvironmentSpecificationVersionResource>> GetAsync(string name, string version, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnvironmentSpecificationVersionsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(name, version, resourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get version. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EnvironmentSpecificationVersionResource> Get(string name, string version, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnvironmentSpecificationVersionsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(name, version, resourceGroupName, workspaceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete version. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string name, string version, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnvironmentSpecificationVersionsOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(name, version, resourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete version. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string name, string version, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnvironmentSpecificationVersionsOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(name, version, resourceGroupName, workspaceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="name"> The String to use. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="orderby"> The String to use. </param>
        /// <param name="top"> The String to use. </param>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public virtual AsyncPageable<EnvironmentSpecificationVersionResource> ListAsync(string name, string resourceGroupName, string workspaceName, string orderby = null, string top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            async Task<Page<EnvironmentSpecificationVersionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EnvironmentSpecificationVersionsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(name, resourceGroupName, workspaceName, orderby, top, skiptoken, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EnvironmentSpecificationVersionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EnvironmentSpecificationVersionsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, name, resourceGroupName, workspaceName, orderby, top, skiptoken, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <param name="name"> The String to use. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="orderby"> The String to use. </param>
        /// <param name="top"> The String to use. </param>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public virtual Pageable<EnvironmentSpecificationVersionResource> List(string name, string resourceGroupName, string workspaceName, string orderby = null, string top = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            Page<EnvironmentSpecificationVersionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EnvironmentSpecificationVersionsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(name, resourceGroupName, workspaceName, orderby, top, skiptoken, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EnvironmentSpecificationVersionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EnvironmentSpecificationVersionsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, name, resourceGroupName, workspaceName, orderby, top, skiptoken, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
