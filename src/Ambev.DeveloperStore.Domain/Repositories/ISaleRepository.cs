﻿using Ambev.DeveloperStore.Domain.Entities;

namespace Ambev.DeveloperStore.Domain.Repositories
{
    public interface ISaleRepository
    {
        /// <summary>
        /// Creates a new sale in the repository
        /// </summary>
        /// <param name="sale">The sale to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created sale</returns>
        Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new saleItem in the repository
        /// </summary>
        /// <param name="saleItem">The saleItem to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created saleItem</returns>
        Task<SaleItem> CreateItemAsync(SaleItem saleItem, CancellationToken cancellationToken);

        /// <summary>
        /// Updated a sale from the repository
        /// </summary>
        /// <param name="id">The unique identifier of the sale to update</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>True if the sale was update, false if not found</returns>
        Task<Sale> UpdateAsync(Sale sale, CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancel a sale from the repository
        /// </summary>
        /// <param name="id">The unique identifier of the sale to cancel</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>True if the sale was cancel, false if not found</returns>
        Task<bool> CancelAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a sale by their unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the sale</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The sale if found, null otherwise</returns>
        Task<Sale?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    }
}
