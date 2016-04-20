global NO_REPLICATIONS ITERMAX NET_ITERMAX NA NS TPM TRM EPSILON LAMBDA FIS ACTION_2_VALUE SLA MONDATA NORMONDATA
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


NO_REPLICATIONS=30; % No of replications of simulation 
ITERMAX=1000; % No of iterations of learning
NET_ITERMAX=1; % No of iterations of neural network training, only used when we use neural netwrok coupled with q learning
% NA=2; % Number of actions in each state 
% NS=3; % Number of states 

EPSILON=0.1; % exploration probability 
LAMBDA=0.8; % discount factor
 
%% MDP: note that the probabilities for each state should sum to one

TPM(:,:,1)=[0.5,0.2,0.3;0.4,0.2,0.4;0.8,0.1,0.1]; % probabilities of going from an state to another state under action 1 

TPM(:,:,2)=[0.4,0.1,0.5;0.2,0.5,0.3;0.1,0.1,0.8]; % probabilities of going from an state to another state under action 2  

TRM(:,:,1)=[16,-5,12;7,12,-2;7,12,-2]; % rewards earned in going from an state to another state under actions 1 
    
TRM(:,:,2)=[0,17,14;-14,13,-4;0,17,14]; % rewards earned in going from an state to another state under actions 2

%% Fuzzy QL
FIS=readfis('robust2scalesg.fis');

NS=size(FIS.rule,2);

NA=size(FIS.output.mf,2);

ACTION_2_VALUE=[-1,0,+1];

SLA=600;  % response time SLO in milli second, SLA(index), index is the index for specific SLO such as rt

MONDATA=csvread('Data/wikipedia_self-adaptive.csv',1,1,[1 1 ITERMAX 2]);

NORMONDATA=scaledata(MONDATA,0,100);
