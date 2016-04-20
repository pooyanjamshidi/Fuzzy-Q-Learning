% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


%%
clearvars -global;
% global variables declared
global ITERMAX NA NS

global4 % global parameters initialized

% variable to set whether we need vector or not, for example in neural
% network version of q_learning we require to set this to 1 otherwise it
% should be set to 0
vector_is_needed=1;

% main data structure including the lookup table and other statistics for storing and tracking
% Q-value. Q:S*A->R, note that we can initialize the Q with any arbitrary
% value
stat=struct('Q',zeros(NS,NA),'iter',0,'old_action',1,'old_state',1,'current_state',1,'rimm',0,'total_reward',0,'vector',zeros(NA,2));

if vector_is_needed==1
    stat=init_vector(stat); % it only usable when we use and update vector, e.g., for neural approximation of Q values otherwise it can be safely commented.
end

%historical values
stat_h=zeros(NS,NA,ITERMAX);

done=0; % 1 stands for stopping the simulation 0 stands for continue

% index for historical Q
i=0;

while 0==done
    i=i+1;
    % simulate a jump in the MDP and learn
    [stat,done]=jump_learn(stat);
    
    % record temporal Q values for simulation diagrams
    stat_h(:,:,i)=stat.Q;
    
end

% finding the learned policy
policy=pol_finder(stat);


