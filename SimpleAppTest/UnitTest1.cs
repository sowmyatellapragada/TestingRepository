using SimpleApp.Models;
using System;
using Xunit;

namespace SimpleAppTest
{
    public class UnitTest1
    {
        [Fact]
        
            public void CanChangeProductName()
            {
                // Arrange
                var p = new Product();
                // Act
                p.Name = "hey";
                //Assert
                Assert.Equal("hey", p.Name);
            }
            [Fact]
            public void CanChangeProductPrice()
            {
                // Arrange
                var p = new Product { Name = "sowmya", Price = 100M };
                // Act
                p.Price = 100M;
                //Assert
               Assert.NotEqual(200M, p.Price);
             
            }
       
        }
    }
