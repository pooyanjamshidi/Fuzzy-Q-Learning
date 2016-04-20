global NO_REPLICATIONS ITERMAX NET_ITERMAX NA NS TPM TRM EPSILON LAMBDA FIS ACTION_2_VALUE SLA MONDATA NORMONDATA

% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


NO_REPLICATIONS=30; % No of replications of simulation 
ITERMAX=3000; % No of iterations of q learning
NET_ITERMAX=1; % No of iterations of neural network training , only used when we use neural netwrok coupled with q learning
% NA=2; % Number of actions in each state 
% NS=2; % Number of states 

EPSILON=0.1; % exploration probability 
LAMBDA=0.8; % discount factor
 
TPM(:,:,1)=[0.7,0.3;0.4,0.6]; % probabilities of going from an state to another state under action 1 

TPM(:,:,2)=[0.9,0.1;0.2,0.8]; % probabilities of going from an state to another state under action 2  

TRM(:,:,1)=[16,-5;7,12]; % rewards earned in going from an state to another state under actions 1 
    
TRM(:,:,2)=[0,17;-14,13]; % rewards earned in going from an state to another state under actions 2


%% Fuzzy QL
FIS=readfis('robust2scalesg.fis');

NS=size(FIS.rule,2);

NA=size(FIS.output.mf,2);

ACTION_2_VALUE=[-1,0,+1];

SLA=600; % response time SLO in milli second, SLA(index), index is the index for specific SLO such as rt

MONDATA=csvread('google.csv',1,1,[1 1 ITERMAX 2]);

% MONDATA=csvread('Data/wikipedia_self-adaptive.csv',1,1,[1 1 ITERMAX 2]);

% MONDATA=csvread('Data/wikipedia_non-adaptive_overProvisioning_6G.csv',1,1,[1 1 ITERMAX 2]);

NORMONDATA=scaledata(MONDATA,0,100);