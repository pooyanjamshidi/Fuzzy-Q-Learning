global FISFILENAME FISTEMPFILENAME ARCHIVEFOLDER NA NS LAMBDA FIS DESIRED_RT MAX_THROUGHPUT W MAX_VM

FISFILENAME='robust2scalesg.fis'; % name of the current rule base useing for reasoning
FISTEMPFILENAME='robust2scalesg9.fis'; % name of rule base transfered from design-time
ARCHIVEFOLDER='myarchive'; % name of the folder used for archiving unused rule bases
FIS=readfis(FISTEMPFILENAME); % read rule base of the FLC
% EPSILON=0.2; % exploration probability 
LAMBDA=0.8; % discount factor
NS=size(FIS.rule,2); % number of states
NA=size(FIS.output.mf,2); % number of actions

DESIRED_RT=600; % response time SLO in milli second, SLA(index), index is the index for specific SLO such as rt
MAX_THROUGHPUT=100; % maximum value of throughput
MAX_VM=2; % use for scaling cost of scaling action
W=[1 1 1]; % weight values used in the reward function