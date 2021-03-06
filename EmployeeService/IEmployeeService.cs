﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        EmployeeInfo GetEmployee(EmployeeRequest request);

        [OperationContract]
        void SaveEmployee(EmployeeInfo employee);
    }
}
