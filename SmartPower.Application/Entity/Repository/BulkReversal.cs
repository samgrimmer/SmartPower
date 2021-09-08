using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SmartPower.Application.Entity.Model.Projection;

namespace SmartPower.Application.Entity.Repository
{
    public class BulkReversal : IBulkReversal
    {
        private readonly DbContext _dbContext;

        public BulkReversal(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BulkReversalSummary>> GetBulkReversals(string userName)
        {
            return await _dbContext.TReversalsBulkLists
                .AsNoTracking()
                    .Where(b => b.UserName == userName)
                        .Select(b => new BulkReversalSummary
                        {
                            RevStatus = b.RevStatus,
                            RevResults = b.RevResults,
                            NewSpInvNumber = b.NewSpInvNumber,
                            OrgSpinvNumber = b.OrgSpinvNumber
                        })
                        .ToListAsync();
        }

        public async Task CreateReversalListItem(string userName, int orgSpinvNumber)
        {
            var reversalBulkListItem = new Model.TReversalsBulkList { OrgSpinvNumber = orgSpinvNumber, UserName = userName };

            _dbContext.Add(reversalBulkListItem);

            await _dbContext.SaveChangesAsync();
        }

        public async Task ClearReversals(string userName)
        {
            await _dbContext.Database.ExecuteSqlInterpolatedAsync($"exec {Constant.StoredProcedures.BulkReversal.ClearReversals} {userName}");
        }

        public async Task UpdateReversalStatus(string userName)
        {
            await _dbContext.Database.ExecuteSqlInterpolatedAsync($"exec {Constant.StoredProcedures.BulkReversal.UpdateReversalStatus} {userName}");
        }
        
        public async Task<bool> TestSuppliedInvoices(string userName)
        {
            var testStatusPass = new SqlParameter { ParameterName = "@Test_Status_Pass", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Output };

            await _dbContext.Database.ExecuteSqlInterpolatedAsync($"exec {testStatusPass}={Constant.StoredProcedures.BulkReversal.TestSuppliedInvoices} {userName}");

            return bool.Parse(testStatusPass.Value.ToString());
        }

        public async Task<int> CreateReversals(string userName)
        {
            var batchNumber = new SqlParameter { ParameterName = "@New_BatchNo", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };

            await _dbContext.Database.ExecuteSqlInterpolatedAsync($"exec {batchNumber}={Constant.StoredProcedures.BulkReversal.CreateReversals} {userName}");

            return int.Parse(batchNumber.Value.ToString());
        }
    }
}
