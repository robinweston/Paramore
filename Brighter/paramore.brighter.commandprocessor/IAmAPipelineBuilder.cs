// ***********************************************************************
// Assembly         : paramore.brighter.commandprocessor
// Author           : ian
// Created          : 07-01-2014
//
// Last Modified By : ian
// Last Modified On : 07-01-2014
// ***********************************************************************
// <copyright file="IAmAPipelineBuilder.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Licence
/* The MIT License (MIT)
Copyright � 2014 Ian Cooper <ian_hammond_cooper@yahoo.co.uk>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the �Software�), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED �AS IS�, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE. */
#endregion

using System;

/// <summary>
/// The commandprocessor namespace.{CC2D43FA-BBC4-448A-9D0B-7B57ADF2655C}
/// </summary>
namespace paramore.brighter.commandprocessor
{
    /// <summary>
    /// Interface IAmAPipelineBuilder{CC2D43FA-BBC4-448A-9D0B-7B57ADF2655C}
    /// </summary>
    /// <typeparam name="TRequest">The type of the t request.</typeparam>
    public interface IAmAPipelineBuilder<TRequest> : IDisposable where TRequest : class, IRequest 
    {
        /// <summary>
        /// Builds the specified request context.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        /// <returns>Pipelines&lt;TRequest&gt;.</returns>
        Pipelines<TRequest> Build(IRequestContext requestContext);
    }
}