global NO_REPLICATIONS ITERMAX NA NS TPM TRM LAMBDA

% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


NO_REPLICATIONS=30; % No of replications of simulation 
ITERMAX=10000; % No of iterations of learning 
NA=2; % Number of actions in each state 
NS=2; % Number of states 

LAMBDA=0.8; % discount factor
 
TPM(:,:,1)=[0.7,0.3;0.4,0.6]; 

TPM(:,:,2)=[0.9,0.1;0.2,0.8]; 

TRM(:,:,1)=[6,-5;7,12]; 
    
TRM(:,:,2)=[12,17;-14,13];

