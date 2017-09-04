﻿using Flepper.Core.Base;

namespace Flepper.Core.QueryBuilder
{
    public class UpdateCommand : BaseFlepperQueryBuilder, IUpdateCommand
    {
        public IUpdateCommand Update(string table)
        {
            BeforeExecute();

            Command.AppendFormat("UPDATE [{0}] ", table);

            return this;
        }

        public IUpdateCommand Update(string schema, string table)
        {
            BeforeExecute();

            Command.AppendFormat("UPDATE [{0}].[{1}] ", schema, table);

            return this;
        }
    }
}