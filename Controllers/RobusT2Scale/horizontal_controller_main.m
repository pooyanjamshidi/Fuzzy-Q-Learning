function scaling_action=horizontal_controller_main(workload,reponse_time,current_vm_no,min_vm,max_vm,max_workload,slo_rt)

% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The scripts implements the horizontal controller.

% Inputs:
% workload,reponse_time: the monitoring data regarding workload and response time

% current_vm_no,min_vm,max_vm: the number of vm currently running and the
% min and max number of allowable VMs which are determined at desing-time

% max_workload,slo_rt: we scale the monitoring data with respect to the
% maximum workload and the desirable response time. These two values are
% supposed to be available at design-time. Note that monitoring data above
% these two thresholds are set to 100 (max value of the scaling interval)

% output:
% scalingaction: {-2, -1, 0, +1, +2}, this determines the change in the number of resources
% ------------------------------------------------------------------------

% normalizing inputs
normalized_workload = scaledata(workload,0,100,max_workload);
normalized_response_time = scaledata(reponse_time,0,100,slo_rt);

% computing scaling action according to the fuzzy controller
scaling_action=RobusT2Scalesg(normalized_workload,normalized_response_time);

% round to the nearest decimal or integer
scaling_action=round(scaling_action);

% evaluating scaling constraint
current_vm_no=current_vm_no+scaling_action;
if (current_vm_no>=min_vm && current_vm_no<=max_vm)
    return
else
    scaling_action=0; % action is igonored
    warning('Controller:InputOutOfRange','The current number of VM cannot be changed due to the violation of scaling constraint');
end

end