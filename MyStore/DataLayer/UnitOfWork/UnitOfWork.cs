﻿using MyStore.DataLayer.Entities;
using MyStore.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace MyStore.DataLayer.UnitOfWork
{
   
        /// <summary>
        /// Unit of Work class responsible for DB transactions
        /// </summary>
        public class UnitOfWork : IDisposable
        {
            #region Private member variables...

            private ApplicationContext _context = null;
            private GenericRepository<Product> _productRepository;
            
            #endregion

            public UnitOfWork()
            {
                _context = new ApplicationContext();
            }

            #region Public Repository Creation properties...

            /// <summary>
            /// Get/Set Property for product repository.
            /// </summary>
            public GenericRepository<Product> ProductRepository
            {
                get
                {
                    if (this._productRepository == null)
                        this._productRepository = new GenericRepository<Product>(_context);
                    return _productRepository;
                }
            }

           
            #endregion

            #region Public member methods...
            /// <summary>
            /// Save method.
            /// </summary>
            public void Save()
            {
                try
                {
                    _context.SaveChanges();
                }
                catch (ValidationException e)
                {

                    var outputLines = new List<string>();
                   
                        outputLines.Add(string.Format($"{DateTime.Now}: Entity  has the following validation errors: {e.Message}"));
                  
                    System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);

                    throw e;
                }

            }

           

            #endregion

            #region Implementing IDiosposable...

            #region private dispose variable declaration...
            private bool disposed = false;
            #endregion

            /// <summary>
            /// Protected Virtual Dispose method
            /// </summary>
            /// <param name="disposing"></param>
            protected virtual void Dispose(bool disposing)
            {
                if (!this.disposed)
                {
                    if (disposing)
                    {
                        Debug.WriteLine("UnitOfWork is being disposed");
                        _context.Dispose();
                    }
                }
                this.disposed = true;
            }

            /// <summary>
            /// Dispose method
            /// </summary>
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            #endregion
        }


    }

